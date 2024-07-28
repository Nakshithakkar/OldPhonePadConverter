# OldPhonePadConverter
C# implementation of an old phone pad converter


A C# program that converts old phone pad button presses into text.

## Description

This program simulates the text input system of old mobile phones, where multiple presses of a number key cycled through the letters associated with that key. For example, pressing '2' once gives 'A', twice gives 'B', and three times gives 'C'.

## Features

- Converts number sequences to corresponding letters
- Handles spaces (0)
- Supports backspace (*)
- Uses '#' as the end-of-input marker

## How to Use

1. Clone the repository:git clone https://github.com/Nakshithakkar/OldPhonePadConverter.git


2. Navigate to the project directory:cd OldPhonePadConverter


3. Compile the C# file:csc OldPhonePadConverter.cs


4. Run the program:OldPhonePadConverter.exe


5. Follow the on-screen prompts to enter your input strings.

## Input Examples

- `4433555 555666#` => `HELLO`
- `2 22 222#` => `ABC`

