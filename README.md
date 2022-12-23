# CoffeeShopper

## After adding all the nugged packages do the following as per Microsoft suggestion.
1) In the console manager in the IdentityServer project add this
  - add-migration InitialIdentityServerMigration -c PersistedGrantDbContext
  - add-migration InitialIdentityServerMigration -c ConfigurationDbContext
2) update-database -Context PersistedGrantDbContext
3) update-database -Context ConfigurationDbContext
