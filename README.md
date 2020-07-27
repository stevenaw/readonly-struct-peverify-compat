Testing the use of the `/features:peverify-compat` flag to bypass VerificationException at runtime
when accessing a member of a readonly struct on CLR4 (NET4, NET45, etc)

- Compile as such:

```
cd ConsoleApp4
csc Program.cs ComparisonState.cs ImmutableStack.cs /features:peverify-compat
```

vs


```
cd ConsoleApp4
csc Program.cs ComparisonState.cs ImmutableStack.cs
```