# BigInteger using GMP

[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)

This is the second version of the BigInteger library, which is wrapped around the GMP library.
The first version of the library was written in a rush and was not very well designed.
This version is a complete rewrite and is designed to be more efficient and easier to use.

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