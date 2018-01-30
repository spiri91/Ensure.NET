# Ensure.NET
Inpired by CodeContracts, small piece of code that allows you to lower the ciclomatic complexity of code by removing some branching.

# Ensure.NET
Inpired by CodeContracts, small piece of code that allows you to lower the ciclomatic complexity of code by removing some branching.
Branching like most precondition, if - else - throw or if - else - set value.

## Examples
```
if (foo == null)
    throw new NullReferenceException();
=> becomes
	Ensure.Condition(foo == boo, new NullReferenceException());
```
--------------------------------------------------------------------------------------------------------------------------------
```
if (foo == goo)
    foo = boo;
=> becomes
    Ensure.Condition(foo == boo, ref foo, boo);
```
--------------------------------------------------------------------------------------------------------------------------------
```
if (ObjectIsValid(foo))
    DoSomething();
=> becomes
    Ensure.Condition(() => ObjectIsValid(foo), () => DoSomething());
```
---------------------------------------------------------------------------------------------------------------------------------
