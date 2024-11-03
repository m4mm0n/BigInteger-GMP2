# BigInteger using GMP

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

This is the second version of the BigInteger library, which is wrapped around the GMP library.
The first version of the library was written in a rush and was not very well designed.
This version is a complete rewrite and is designed to be more efficient and easier to use.

# BigIntegerGMP2 Improvements over BigIntegerGMP

## Overview
This document summarizes the key improvements made in the `BigIntegerGMP2` library compared to the previous version. It provides an overview of enhanced features, improved usability, and newly added functionalities that make the updated library more robust and easier to use.

## Improvements Summary

### 1. Enhanced Interoperability and Conversion Capabilities
- **Explicit and Implicit Conversions**: Added support for type conversion operators to convert between `BigInteger` and common data types (`mpz_t`, byte arrays, strings, integers, unsigned integers, etc.).
- **Intuitive Integration**: This allows for more seamless integration with C# types, minimizing code complexity and enabling natural usage.

### 2. Expanded Arithmetic and Logical Operators
- Added **full suite of arithmetic operators** (`+`, `-`, `*`, `/`, `%`) and **logical operators** (`&`, `|`, `^`, `~`), along with **shift operators** (`<<`, `>>`).
- **Increment (`++`) and Decrement (`--`) operators** were also added to provide easier iteration over BigInteger values.
- These additions make the library more natural to use, similar to native integer types.

### 3. Improved Comparison and Equality Functions
- **Comprehensive Comparisons**: Added comparison functions (`<`, `<=`, `>`, `>=`) and multiple `CompareTo()` overloads, allowing comparisons between `BigInteger` and common data types (`int`, `long`, `double`, etc.).
- **Overridden `Equals()` Method**: Enhanced equality checks to ensure consistent behavior regardless of data types.
- **Absolute Comparisons**: Added methods for **absolute value comparison** (`CompareAbsTo()`).

### 4. Additional Utility Functions
- **Conversion Methods**: Expanded utility with functions like `ToInt32()`, `ToInt64()`, `ToDouble()`, and `ToByteArray()`.
- **Base Conversion**: Added `ToString(int radix)` and `ToString(BaseFormat)` for conversion to different bases.
- **Base-64 Conversion**: Added methods for **Base-64 encoding and decoding** to ease serialization and deserialization.

### 5. Random Number Generation
- Added **random number generation** with specific bit lengths and within a given range.
- Utilizes **GMP's random number generator**, providing enhanced randomness and cryptographic utility.

### 6. Specialized Mathematical Functions
- **Jacobi and Kronecker Symbols**: Added methods to compute these symbols, providing important utility for number theory and cryptographic algorithms.
- **Fibonacci and Lucas Numbers**: Functions to compute **Fibonacci and Lucas numbers**, including predecessor values.
- **Extended Euclidean Algorithm** and **Modular Inverse**: Added these algorithms for use in modular arithmetic and cryptographic applications.

### 7. Logging and Debugging Enhancements
- Introduced a **`ShouldLog` property** to toggle logging capabilities, allowing detailed tracing during development and debugging. (Still not implemented!)

### 8. Better Memory Management
- Implemented **`Dispose()` method** and **`IDisposable` interface** for better management of unmanaged resources and to reduce memory leaks.

### 9. Mathematical Extensions
- **Chinese Remainder Theorem (CRT)**: Added functionality to solve simultaneous congruences.
- **Least Common Multiple (LCM)**: Added methods to compute LCM for `BigInteger` and standard types.

### 10. Constants and Predefined Values
- Added constants like **`Zero`, `One`, `Two`, `Three`, and `MinusOne`** to improve readability and reuse of common values.

### 11. Bitwise Operations and Hamming Distance
- **Bitwise Operations**: Added `&`, `|`, `^`, `~` operations, providing the capability for bit-level manipulation.
- **Hamming Distance**: Added a method to compute the **Hamming Distance** between two `BigInteger` values, useful in error detection/correction and cryptography.

## Features
- **Efficient**: The library is wrapped around the GMP library, which is a highly optimized library for arbitrary precision arithmetic.
- **Easy to use**: The library is designed to be easy to use and understand.
- **Well documented**: The library is well documented and has a lot of examples.
- **Windows only**: The library is currently only supported on Windows - and only on x64.

## Building
- **Requirements**: You need to have Visual Studio 2022 installed on your system.
- **Steps**:
  1. Clone the repository.
  2. Open the solution file in Visual Studio.
  3. Build the solution.
  4. Select 'Debug-MemoryLoad' or 'Release-MemoryLoad' for the experimental build where the native GMP library is loaded from memory.


## Dependencies
This project depends on the [QuickLog](https://github.com/m4mm0n/QuickLog) logging library.

## Acknowledgements
- [GMP](https://gmplib.org/): The GNU Multiple Precision Arithmetic Library.
- [MpfrDotNet](https://github.com/dlebansais/MpfrDotNet): The original library that is the core of this library.
- [Sdcb.Arithmetic](https://github.com/sdcb/Sdcb.Arithmetic): The library that inspired me to start this project anew.