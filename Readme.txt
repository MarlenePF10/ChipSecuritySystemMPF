# Chip Sequence Solver

This repository contains a solution to the chip sequence problem where the goal is to find a valid sequence of chips that starts with `Blue` and ends with `Green`. The sequence of chips must connect in such a way that the `EndColor` of one chip matches the `StartColor` of the next chip.

Two algorithms have been implemented to solve this problem:

1. **Depth First Search (DFS)** - This algorithm explores all possible sequences recursively and finds the longest valid sequence. 
2. **Greedy Algorithm** - This algorithm builds the sequence by always picking the first available chip that matches the current color. It is designed for graphs with a large number of nodes, aiming to find a solution more quickly.

## How It Works

- The program uses a set of bi-colored chips, each having a `StartColor` and an `EndColor`.
- The goal is to connect these chips in a way that the `StartColor` of the first chip matches `Blue`, and the `EndColor` of the last chip matches `Green`.
- Both algorithms attempt to find the longest possible sequence, using different strategies.

### Algorithms:

- **DFS**: This approach recursively explores all potential sequences and returns the one with the maximum number of chips, ensuring that the sequence ends with `Green`.
  
- **Greedy**: This method iteratively picks the first available chip that matches the current color and adds it to the sequence.

## Installation

To run the project locally:

1. Clone this repository to your local machine

2. Open the project in your favorite C# IDE or text editor.

3. Build and run the project.

## Contributing

Feel free to open issues or submit pull requests to improve the solution.

## License

This project is licensed under the CT License
