﻿namespace AgencyPro.Domain.Entities;

public class FixedPriceProposal : BaseEntity<FixedPriceProposal>, IFixedPriceProposal
{
    [ForeignKey("Id")] public Project Project { get; set; }
    public ProposalAcceptance ProposalAcceptance { get; set; }

    public ICollection<ProposalWorkOrder> WorkOrders { get; set; }
    public ICollection<ProposalNotification> Notifications { get; set; }

    public Guid CreatedById { get; set; }
    public Guid UpdatedById { get; set; }

    public string ConcurrencyStamp { get; set; } = null!;

    public decimal WeeklyCapacity
    {
        get => WeeklyMaxHourBasis * VelocityBasis;
        set { }
    }

    public decimal DailyCapacity
    {
        get => WeeklyCapacity / 7;
        set { }
    }

    public decimal TotalDays
    {
        get => TotalHours / DailyCapacity + ExtraDayBasis;
        set { }
    }

    public decimal RetainerPercent { get; set; }

    public Guid Id { get; set; }

    public decimal VelocityBasis { get; set; }

    public decimal WeeklyMaxHourBasis { get; set; }

    public string AgreementText { get; set; } = null!;

    public decimal? BudgetBasis { get; set; }

    public ProposalStatus Status { get; set; }

    public ProposalType ProposalType { get; set; }

    public int StoryPointBasis { get; set; }

    public int EstimationBasis { get; set; }

    public decimal OtherPercentBasis { get; set; }

    public int ExtraDayBasis { get; set; }

    public decimal CustomerRateBasis { get; set; }

    public int StoryHours
    {
        get => StoryPointBasis * EstimationBasis;
        set { }
    }

    public decimal TotalHours
    {
        get => StoryHours * (1 + OtherPercentBasis);
        set { }
    }

    public decimal TotalPriceQuoted
    {
        get => TotalHours * CustomerRateBasis;
        set { }
    }

    public override void Configure(EntityTypeBuilder<FixedPriceProposal> builder)
    {
        builder.ToTable("Proposal");
        builder.Property(x => x.CustomerRateBasis);
        builder.Property(x => x.StoryPointBasis);
        builder.Property(x => x.EstimationBasis);
        builder.Property(x => x.ExtraDayBasis);
        builder.Property(x => x.OtherPercentBasis)
            .HasDefaultValue(0)
            .HasColumnType("decimal(3,2)");


        var storyPointBasis = $@"[{nameof(StoryPointBasis)}]";
        var estimationBasis = $@"[{nameof(EstimationBasis)}]";
        var otherPercentBasis = $@"[{nameof(OtherPercentBasis)}]";
        var customerRateBasis = $@"[{nameof(CustomerRateBasis)}]";
        var extraDayBasis = $@"[{nameof(ExtraDayBasis)}]";

        var storyHourComputation = $@"({storyPointBasis}*{estimationBasis})";
        var totalHoursComputation = $@"({storyHourComputation} * (1 + {otherPercentBasis}))";
        var totalPriceComputation = $@"({totalHoursComputation} * {customerRateBasis})";

        var velocityBasis = $@"[{nameof(VelocityBasis)}]";
        var maxHourBasis = $@"[{nameof(WeeklyMaxHourBasis)}]";

        var weeklyCapacityComputation = $@"({maxHourBasis} * {velocityBasis})";
        var dailyCapacityComputation = $@"({weeklyCapacityComputation} / 7)";
        var totalDayComputation = $@"(({totalHoursComputation}/{dailyCapacityComputation})+{extraDayBasis})";

        builder.Property(x => x.TotalDays)
            .HasComputedColumnSql(totalDayComputation);

        builder.Property(x => x.StoryHours)
            .HasComputedColumnSql(storyHourComputation);

        builder.Property(x => x.TotalHours)
            .HasComputedColumnSql(totalHoursComputation);

        builder.Property(x => x.TotalPriceQuoted)
            .HasComputedColumnSql(totalPriceComputation);

        builder.Property(x => x.WeeklyCapacity)
            .HasComputedColumnSql(weeklyCapacityComputation);

        builder.Property(x => x.DailyCapacity)
            .HasComputedColumnSql(dailyCapacityComputation);

        builder.Property(x => x.VelocityBasis)
            .HasDefaultValue(1)
            .HasColumnType("decimal(3,2)");

        builder.Property(x => x.BudgetBasis)
            .HasColumnType("Money")
            .IsRequired(false);


        //builder.Property(x => x.AverageCustomerRate)
        //    .HasColumnType("Money");


        builder.Property(u => u.ConcurrencyStamp)
            .IsConcurrencyToken();

        builder.Property(x => x.ProposalType)
            .HasDefaultValue(ProposalType.Fixed);

        builder.Property(x => x.WeeklyMaxHourBasis);

        builder
            .HasOne(x => x.Project)
            .WithOne(x => x.Proposal)
            .OnDelete(DeleteBehavior.Cascade);
    }
}