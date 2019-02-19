Return the minimum list of ordered points required to draw an outline of a list of rectangles.
Draw a line starting at the bottom leftmost point of any building that finishes at the bottom rightmost point of any building, following the line of the buildings in between.
Assume that all rectangles are defined by a bottom left corner(x, y), a width and a height.

Recommended approach in order to practice thinking about data structures and algorithms:
Start by writing very high level pseudocode for the solution in notepad. Don't worry about data structures, or manipulating geometry, just write down what you'd ideally want to do as a list of instructions.
This allows you to understand the interesting cases before pinning down implementation details.

For example you should be saying things like "get the building with the furthest left x co-ordinate" rather than "order the collection by x co-oridinate and get the first"