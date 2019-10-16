# Relational sequence

*Made by Rasmus Nordbjærg with C# .NET Core*

### Description
The task was to create a class (Relationals) which were able to loop over positive rational numbers or retrieve one at a given index. The class should implement the *IEnumerable* interface.

## My solution

I created the classes:
* *Relationals*: the class described in the description.
* *Fraction*: a class to store the numerator and denominator instead of just calculated the *double* value. This allowed for prettier printable output and stil allows to get the *double* value of the fraction.

## Limitations

The implementation contains following limitations:
* Natural limitation of *uint* maximum value.
* Natural limitation of maximum number of digits in a *double*.
* *Fraction* class doesn't have any calculation features implemented other than getting the *double* value of the fraction.

## Conclusion

The solution solves the task I was given. It could be improve by adding methods for calculation with *Fractions* but that would be out of scope for the assignment.
