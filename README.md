# String Manipulation Coding Test

## Overview
This coding test evaluates your ability to implement string manipulation algorithms in C#. You'll be working with the `StringTools` class, which contains three methods that need to be implemented according to the provided unit tests.

## Requirements
- .NET Core SDK
- An IDE of your choice (Visual Studio, VS Code, Rider, etc.)

## Instructions
1. Clone/download this repository
2. Open the solution in your preferred IDE
3. Navigate to the `StringTools.cs` file
4. Implement the following methods:

### 1. FindFirstDuplicatedCharacter
```csharp
public string FindFirstDuplicatedCharacter(string input)
```
- Find and return the first character that appears more than once in the input string
- The comparison should be case-sensitive
- Return `null` if no duplicates are found or if the input is null/empty

Examples:
- "ABCBA" → "B"
- "ABCABA" → "A"
- "ABCDEFG" → null

### 2. IsPalindrome
```csharp
public bool IsPalindrome(string input)
```
- Determine if the input string is a palindrome (reads the same forwards and backwards)
- The comparison should be case-insensitive
- Return `false` for null, empty, or whitespace-only strings
- Single characters should return `true`

Examples:
- "civic" → true
- "CIVIC" → true
- "palindrome" → false
- "A" → true

### 3. FindLargestPalindrome
```csharp
public string FindLargestPalindrome(string input)
```
- Find and return the largest palindrome within the input string
- If multiple palindromes of the same length exist, return the first one
- Return `null` if no palindrome is found
- The comparison should be case-sensitive
- Return the exact substring including any spaces

Examples:
- "Hello I am civic ana" → " civic "
- "ghuewidhebdbobdsgyeb" → "dbobd"
- "AB" → null

## Testing
- Use the provided `StringToolsTests.cs` file to verify your implementations
- All tests must pass for the solution to be considered complete
- Do not modify the test cases

## Evaluation Criteria
Your solution will be evaluated based on:
1. Correctness: All test cases must pass
2. Code quality and readability
3. Performance and efficiency of your implementations
4. Proper handling of edge cases

## Submission
1. Ensure all tests pass
2. Remove any unnecessary comments or debug code
3. Submit your completed `StringTools.cs` file

## Time Limit
Please complete this test within [TIME_LIMIT] hours of receiving it.

Good luck!
