# C# Exception Handling Bug: Corrupted Object State

This repository demonstrates a common C# bug related to improper exception handling.  The code attempts to handle exceptions but fails to address the potential for corrupted object state after an exception occurs.  This can lead to unpredictable program behavior and difficult-to-debug errors.

## Bug Description
The `ExampleClass` contains a method `DoSomething` that attempts to perform an operation that could throw an exception.  The exception is caught, but the object's internal state might be left inconsistent.  This is a subtle but significant error that frequently occurs in complex applications.

## Solution
The solution involves implementing proper recovery mechanisms within the exception handling block. This can include setting the object to a known valid state, rolling back changes, or throwing a more specific exception to indicate the failure.