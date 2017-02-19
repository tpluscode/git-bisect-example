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
git bisect run ../bisect.sh
```

`bisect.sh`:

``` sh
#!/bin/sh

dotnet build ./src/Kalkulator || exit 125

./src/Kalkulator/bin/Debug/netcoreapp1.0/win7-x64/Kalkulator.exe 3 - 3 | grep 0
```

When done:

```
git bisect reset
```
