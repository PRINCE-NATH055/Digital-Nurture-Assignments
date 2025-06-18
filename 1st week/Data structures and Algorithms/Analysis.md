#  Financial Forecasting: Iterative vs Recursive Methods

##  Summary

> **In simple terms**, the **iterative method** is preferred in C# because  the iterative method is more efficient as it **avoids the overhead of recursive calls**. While both recursion and iteration have the same time complexity of O(n), **recursion creates a new stack frame for each call**, which **increases memory usage** and can lead to **stack overflow for large inputs**. The **iterative approach uses a simple loop**, runs in **constant stack space**, and is generally faster and safer — especially when forecasting over thousands of periods. It’s the most practical choice for long-term, performance-sensitive computations in C#.

