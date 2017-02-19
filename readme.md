# Example of `git bisect`

Manually:

```
git bisect start
git bisect bad
git bisect good 6ad9aad
```

Automatic:

```
git bisect start HEAD 6ad9aad
git bisect run dotnet run --project src/Kalkulator 3 - 3 | grep "Wynik: 0"
```
