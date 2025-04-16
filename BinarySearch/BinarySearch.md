# Binary Search Algorithm

![Confused person reading a book](algorithms/pictures/binary-search.png)

## 🧠 Problem Definition
Imagine you have a **sorted** collection of elements and want to find a specific one as quickly and efficiently as possible.  
How do you do that? The **Binary Search algorithm** is the perfect solution for this!

---

## 🔎 Example Use Case
You have a phonebook and want to find a specific name, let's say **"Julia"**.

Instead of checking every name one by one, the fastest way is:

1. Open the phonebook in the **middle**.
2. Check if **"Julia"** comes **before** or **after** the current page.
3. If it's before, repeat the process on the **first half**.
4. If it's after, repeat the process on the **second half**.
5. Continue this until you find the name.
6. If the name isn't found, return a value that indicates it was not found (e.g., `-1`).

---

## 💡 Solution Explanation
Instead of going through each element one by one (like a linear search),  
**Binary Search** cuts the collection in half at every step, making it **much faster**.

---

## 📈 Time and Space Complexity
- **Time Complexity:** O(log n)  
  Binary Search divides the search space in half with each step.
- **Space Complexity:** O(1)  
  It requires a constant amount of space (unless implemented recursively).

---

## 💬 Additional Notes
- ⚠️ Your data **must be sorted** for Binary Search to work correctly.  
  If the collection is unsorted, splitting it in half won't help—you'll need to sort it first or use another method.
