# TechValley to Bespoke Migration Todo List

## Foundation Projects
- [ ] TechValley.Shared → src/Bespoke.Shared (new)
- [ ] TechValley.Core → src/Bespoke.Core (merge with existing)

## Data Projects
- [ ] TechValley.Data → src/Bespoke.Data (new)
- [ ] TechValley.Data.SqlServer → src/Bespoke.Data.SqlServer (new)

## Service Layer
- [ ] TechValley.Services → src/Bespoke.Services (new)
- [ ] TechValley.Rest → src/Bespoke.Rest (new)

## User Management
- [ ] TechValley.Users → src/Bespoke.Users (new)

## Azure Integration Projects
- [ ] TechValley.Azure → src/Bespoke.Azure (new)
- [ ] TechValley.Azure.AD → src/Bespoke.Azure.AD (new)
- [ ] TechValley.AppInsights → src/Bespoke.Azure.AppInsights (new)
- [ ] TechValley.Azure.BlobStorage → src/Bespoke.Azure.BlobStorage (new)
- [ ] TechValley.Azure.Queue → src/Bespoke.Azure.Queue (new)
- [ ] TechValley.Azure.TableStorage → src/Bespoke.Azure.TableStorage (new)

## Payment Processing Projects
- [ ] TechValley.Payments → src/Bespoke.Payments (new)
- [ ] TechValley.Payments.Stripe → src/Bespoke.Payments.Stripe (new)

## Infrastructure Projects
- [ ] TechValley.Bicep → src/Bespoke.Bicep (new)
- [ ] TechValley.Handlebars → src/Bespoke.Handlebars (new)

## Test Projects
- [ ] TechValley.Tests → tests/Bespoke.Tests (new)
- [ ] TechValley.IntegrationTesting → tests/Bespoke.IntegrationTesting (new)

## Demo Projects
- [ ] TechValley.Benchmarks → demo/Bespoke.Benchmarks (new)

## Migration Steps
1. Backup solution file
2. Update solution file with new projects
3. Migrate foundation projects
4. Merge TechValley.Core with Bespoke.Core
5. Migrate data projects
6. Migrate service layer
7. Migrate REST API layer
8. Migrate user management
9. Migrate Azure projects
10. Migrate payment projects
11. Migrate Bicep and Handlebars projects
12. Migrate test projects
13. Migrate benchmarks to demo
14. Update global references
15. Verify migration
16. Remove original TechValley projects
17. Commit and push changes
