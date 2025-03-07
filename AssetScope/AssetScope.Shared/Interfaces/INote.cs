namespace AssetScope.Shared.Interfaces;

public interface INote
{
    int Id { get; set; }
    string NoteText { get; set; }
    int ContractItemId { get; set; }
    int UserId { get; set; }
}