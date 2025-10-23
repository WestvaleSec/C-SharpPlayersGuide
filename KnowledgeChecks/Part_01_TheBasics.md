===========================================

C# Player’s Guide - Knowledge Checks

Part 01: The Basics

===========================================



\[✓] Check 1 – C#

Q: **True/False.** C# is a special-purpose language optimized for making web applications.

A: False. It is a multi-purpose language.



Q: What is the name of the framework that C# runs on?

A: .NET



-------------------------------------------



\[✓] Check 2 – Variables

Q: Name the three things all variables have.

A: A name, a value, and a type.



Q: **True/False.** Variables must always be declared before being used.

A: True.



Q: Can you redeclare a variable?

A: No. You can reassign a value to a variable. Not redeclare the variable.



Q: Which of the following are legal C# variable names? **answer, 1stValue, value1, $message, delete-me, delete\_me, PI**.

A: answer, value1, delete\_me, PI



-------------------------------------------



\[✓] Check 3 – Type System

Q: **True/False**. The **int** type can store any possible integer.

A: False. It has a limited range.



Q: Order the following by how large their range is, from smallest to largest: **short, long, int, byte**.

A: byte, short, int, long



Q: **True/False**. The **byte** type is signed.

A: True. It can store values from -128 to 127.



Q: Which can store higher numbers, **int** or **uint**?

A: uint, because it is unsigned and can only store positive numbers, allowing it to use the full range of its bits for positive values.



Q: What three types can store floating-point numbers?

A: float, double, decimal



Q: Which of the options in question 5 can hold the largest numbers?

A: double



Q: Which of the options in question 5 is the most precise?

A: decimal



Q: What type does the literal value **"8"** (including the quotes) have?

A: string



Q: What type stores true or false values?

A: boolean (bool)



-------------------------------------------



\[✓] Check 4 – Memory

Q: **True/False**. You can access anything on the stack at any time.

A: False, you can only access the top layer of the stack.



Q: **True/False**. The stack keeps track of local variables.

A: True.



Q: **True/False**. The contents of a value type can be placed on the heap.

A: True.



Q: **True/False**. The contents of a value type are *always* placed on the heap.

A: False. *Usually*, the contents of a value type are put directly in the stack.



Q: **True/False**. The contents of reference types are *always* placed on the heap.

A: True. *reference* types explicityly means they *point* to the contents inside, on the heap.



Q: **True/False**. The garbage collector cleans up old, unused space on the heap and stack.

A: True. This means we don't need to manually release memory like in C++.



Q: **True/False**. If **a** and **b** are array variables referencing the same object, modifying **a** affects **b** as well.

A: True. If they have the same reference, then they are both pointing to the same object.



Q: **True/False**. If **a** and **b** are **ints** with the same value, changing **a** will also affect **b**.

A: False. *ints* are a value type, meaning they are *almost always* copied directly onto the stack.



-------------------------------------------



End of Part 01



