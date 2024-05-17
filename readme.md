## Utworzenie migracji
Aby utworzyć migrację należy podać projekt gdzie znajduje się DbContext, jak i projekt startowy. 
Można to zrobić poniższa komendą.
```bash
dotnet ef migrations add <Nazwa Migracji> --project .\Flow.Infrastructure\ --startup-project .\Flow\
```
Trójkątne nawiasy nalezy zamienić na nazwę migracji.