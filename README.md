# Find Primes

*Author: Scott Falbo*

---

## Description

A simple class implementation that contains three methods to check if value is prime, return an integer value of the number of primes before a given value, and a list of the those prime numbers.

---

## Getting Started

+ `https://github.com/scottfalbo/find-primes.git`
+ If you run the project there is a simple console UI to demonstrate the class.

---

## `FindPrimes`

[`FindPrimes.cs`](https://github.com/scottfalbo/find-primes/blob/main/FindPrimes/FindPrimes.cs)

### Methods

| Method | Summary | Big O Time | Big O Space | Example |
| :- | :- | :- | :- | :- |
| `bool IsPrime()` | Checks to see if a given value is prime, returns true or false. | O(n) | O(1) | `FindPrimes.IsPrime(int n)` |
| `int TotalPrimesBeforeN` | Given an integer value returns the total number of prime numbers before that value. | O(n^2) | O(1) | `FindPrimes.TotalPrimesBeforeN(int n)` |
| `List<int> PrimesBeforeN` | Given an integer value returns a list of all prime numbers before that value. | O(n^2) | O(n) | `FindPrimes.PrimesBeforeN(int n)` |

---

## `IsPrime()` Algorithm

```c#
public static bool IsPrime(int n)
{
    if (n < 2)
    {
        return false;
    }

    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
```

### Step Through

#### Case 1

+ input <-- `9`
+ expect --> `false`

| `( n )` | `( i )` | `( if (n % i == 0) )` |
| :- | :- | :- |
| 9 | 2 | 9 % 2 = 0.5 : false |
| 9 | 3 | 9 % 3 = 0 : true |

+ return `false`

---

#### Case 2

+ input <-- `11`
+ expected --> `true`

| `( n )` | `( i )` | `( if (n % i == 0) )` |
| :- | :- | :- |
| 11 | 2 | 11 % 2 = 0.5 : false |
| 11 | 3 | 11 % 3 = 0.67 : false |
| 11 | 4 | 11 % 4 = 0.75 : false |
| 11 | 5 | 11 % 5 = 0.2 : false |
| 11 | 6 | 11 % 6 = 0.83 : false |
| 11 | 7 | 11 % 7 = 0.57 : false |
| 11 | 8 | 11 % 8 = 0.38 : false |
| 11 | 9 | 11 % 9 = 0.22 : false |
| 11 | 10 | 11 % 10 = 0.1 : false |

+ `for (int i = 2; i < n; i++)`
  + i = 11 !< n = 11
+ return `true`
