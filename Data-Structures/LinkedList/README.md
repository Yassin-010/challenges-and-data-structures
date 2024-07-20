# Singly Linked List Implementation in C#

## Challenge

Implement a basic singly linked list data structure in C#. The implementation should include the following functionalities:

- A `Node` class to represent each element in the list.
- A `LinkedList` class to manage the nodes.

## Requirements

### Node Class

- **Properties**:
  - `Data`: Stores the value of the node.
  - `Next`: Stores the reference to the next node in the linked list.

### LinkedList Class

- **Properties**:
  - `head`: Stores the reference to the first node in the linked list.

- **Methods**:
  - `Add(int data)`: Adds a new node with the specified value to the end of the linked list.
  - `Includes(int data)`: Checks if the linked list contains a node with the specified value.
  - `Remove(int data)`: Removes the first node with the specified value from the linked list.
  - `PrintList()`: Prints the contents of the linked list in order.

## Example Usage

1. **Add Nodes**:
   - Add nodes with values 5, 10, 20, and 30 to the linked list.
   
2. **Print List**:
   - Output: `Head -> 5 -> 10 -> 20 -> 30 -> Null`

3. **Remove a Node**:
   - Remove the node with the value 10.
   - Output after removal: `Head -> 5 -> 20 -> 30 -> Null`

4. **Check for a Value**:
   - Check if the list includes the value 20 (returns `true`).
   - Check if the list includes the value 10 (returns `false`).

## Exception Handling

- Ensure the implementation handles typical use cases without explicit exception handling.
- For robust error handling, consider adding try-catch blocks where necessary.


## Whiteboard Image

![Linked List Implementation](cc7.png)
