# Binary Search Algorithm 🔍

<img src="https://raw.githubusercontent.com/LuisPereir4/algorithms/main/pictures/binary-search.png" alt="Confused person reading a book" width="300"/>

## 🧠 Problem Definition
Imagine you have a **sorted** collection of elements and want to find a specific one as quickly and efficiently as possible.  
How do you do that? The **Binary Search algorithm** is the perfect solution for this!

## 🔎 Example Use Case
Imagine you're looking for a specific name, like **"Julia"**, in a **printed phonebook**.

Instead of flipping through each page one by one, you open the book right in the **middle** and check if "Julia" comes **before** or **after** the current page.  
You then repeat this process, always narrowing the search space in half, until you either find the name or confirm it’s not in the book.

This is how binary search works — by **eliminating half of the remaining options at each step**.

## 💡 Solution Explanation
Binary Search works by repeatedly dividing the **search interval** in half:

1. Start with the entire sorted collection.
2. Find the **middle element**.
3. Compare the target value with the middle element:
   - If they are equal → you found the item!
   - If the target is **less than** the middle → repeat the search in the **left half**.
   - If the target is **greater than** the middle → search the **right half**.
4. Repeat the steps until the element is found or the search interval becomes empty.

This approach **drastically reduces** the number of comparisons compared to checking each element one by one.

## 📈 Time and Space Complexity
- **Time Complexity:** O(log n)  
  At each step, the algorithm cuts the search space in half.
- **Space Complexity:** O(1)  
  Uses constant space (iterative version). Recursive implementations may use O(log n) due to the call stack.

## 💬 Additional Notes
- To apply the Binary Search algorithm the input collection **must be sorted**.
