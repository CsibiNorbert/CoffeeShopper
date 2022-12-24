# CoffeeShopper

## Important Information
- We use AspNetIdentity which allows us to manage users and their roles and claims.
- Then we use IdentityServer4 to secure our applications to validate the token that's passed in, e.g bearer token with the request against the tbles that have been created. 

**NOTE**: Those tables need to be populated by us.

## After adding all the nugged packages do the following as per Microsoft suggestion in this order.

1) In the console manager in the IdentityServer project add this
  - add-migration InitialIdentityServerMigration -c PersistedGrantDbContext
  - add-migration InitialIdentityServerMigration -c ConfigurationDbContext
2) update-database -Context PersistedGrantDbContext
3) update-database -Context ConfigurationDbContext
4) In the IdentityServer project (Where the actual Authentication bit are) create an AspNetIdentityDbContext which inherits from IdentityDbContext
5) Then run this migration to create the Identity and create the tables with the users, roles etc add-migration InitialAspNetIdentityMigration -c AspNetIdentityDbContext
6) update-database -Context AspNetIdentityDbContext

By default the tables are empty, hence we will need to add some static data e.g users in order the app to work with right at the beggining.
