# RSA Factorizer - Proof of Concept

This repository provides a proof-of-concept implementation of several RSA factorization algorithms, intended for educational purposes only. The library includes a base class, `RSAFactorBase`, which is extended by different factorization classes to demonstrate how various number theory algorithms work in practice for breaking RSA keys. Please note that this project is **not suitable for production use**—it is meant for learning, experimentation, and testing in controlled environments.

## Features and Included Factorization Methods

This RSA factorization project includes the following methods:

### 1. Trial Division Factorizer (`TrialDivisionFactorizer`)
The `TrialDivisionFactorizer` uses a basic trial division method for factoring RSA moduli. It is suitable only for very small numbers (16 to 32 bits) since its time complexity makes it impractical for larger inputs.
- **Complexity**: Exponential in terms of the modulus.
- **Use Case**: Demonstrates the fundamental idea of factorization using successive division, mainly useful as a starting point for understanding more advanced methods.
- **Class**: `TrialDivisionFactorizer`

### 2. Pollard's Rho Factorizer (`PollardsRhoFactorizer`)
The `PollardsRhoFactorizer` is an implementation of Pollard's Rho algorithm, which finds a non-trivial factor of a number using an iterative approach with cycle detection. This implementation also utilizes **Brent's modification** for faster convergence.
- **Bit Range**: Suitable for 33 to 64-bit numbers.
- **Complexity**: Sub-exponential for numbers with small factors.
- **Use Case**: Effective for numbers in the mid-range bit size where trial division is too slow, but other, more complex methods may be overkill.
- **Class**: `PollardsRhoFactorizer`

### 3. Lenstra's Elliptic Curve Method (ECM) Factorizer (`EcmFactorizer`)
The `EcmFactorizer` uses **Lenstra's Elliptic Curve Method** (ECM) to find non-trivial factors. ECM is a powerful tool for factoring numbers with moderately-sized prime factors and is often used in practice for numbers in the range of **65 to 100 bits**.
- **Bit Range**: Suitable for 65 to 100-bit numbers.
- **Complexity**: Sub-exponential for numbers with suitable-sized factors, but often requires several elliptic curves for robustness.
- **Use Case**: Useful for moderate-sized numbers where the factor is not too large. Demonstrates how elliptic curves can be used to perform factorization.
- **Class**: `EcmFactorizer`

## Usage
This project demonstrates how to use different RSA factorization techniques by providing simple API classes for each method. Below is a brief example of how to use one of the factorizers to factor a number.

### Example: Using Pollard's Rho Factorizer
```csharp
using BigIntegerGMP2.RSAFactoring;
using System;

class Program
{
    static void Main(string[] args)
    {
        BigInteger modulus = new BigInteger("9516311845790656153499716760847001433441357");
        var factorizer = new PollardsRhoFactorizer(modulus);

        var factors = factorizer.Factorize();
        Console.WriteLine("Factors:");
        foreach (var factor in factors)
        {
            Console.WriteLine(factor);
        }
    }
}
```

### Classes Overview
- **`RSAFactorBase`**: The base class for all factorization methods, defining a general structure and utilities common to all factorization approaches.
- **`TrialDivisionFactorizer`**: Implements a simple trial division method for small numbers.
- **`PollardsRhoFactorizer`**: Uses Pollard's Rho method with Brent's modification for better performance.
- **`EcmFactorizer`**: Implements Lenstra's ECM to factor numbers efficiently, using elliptic curves.

## Why This Project Is a Proof of Concept
This project is intended solely as a **learning tool** and **proof of concept**. None of the methods implemented here are optimized for speed or for working with large numbers typically used in real RSA implementations. Specifically:

1. **Limited Range**: The implemented methods are suitable for relatively small numbers (up to around 100 bits). Real-world RSA keys are typically 2048 bits or more, which are beyond the capabilities of these simple factorization approaches.
2. **Basic Implementations**: The algorithms are implemented in a straightforward way without the optimizations required for handling large inputs or for robust performance.
3. **Security Limitations**: The factorization methods are slow and insecure for practical use cases, and they do not leverage sophisticated optimizations or parallel computing that are common in production-grade factoring tools.

## When to Use This Project
- **Educational Purposes**: Learn about the different factorization techniques used in RSA cryptography and understand the principles behind them.
- **Testing Small RSA Keys**: Use it for testing and experimenting with RSA keys of very small sizes (16 to 100 bits).
- **Proof of Concept**: Demonstrate the vulnerabilities of RSA when small key sizes are used, emphasizing the importance of using large key sizes in practice.

## Do Not Use for Real Encryption
This project is **not** suitable for use in any real cryptographic application or in any production environment. The code here is for educational purposes, to demonstrate the basics of factorization, and should not be relied upon for securing data or breaking real RSA keys.

## Contributing
Contributions are welcome for extending the factorization capabilities or optimizing the current implementations. However, keep in mind the intended use of this project is for educational demonstrations and not for high-performance cryptographic applications.

## License
This project is licensed under the MIT License. Feel free to modify and share, but remember to respect the original authors and intent.