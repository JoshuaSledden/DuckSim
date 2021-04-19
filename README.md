# DuckSim (Strategy Pattern Exercise)

This was just a small personal dive in to some design pattern work whilst reading the "Head First Design Patterns" book.

## Strategy Pattern
The theme around this Duck Sim app was to demonstrate an applicable usage of the Strategy Pattern.
A design increment requests the addition of a "Fly" function for ducks, however not all ducks are supposed to be able to fly.

We need to implement the new functionality in a way that is flexible at runtime for different types of ducks and doesn't involve a lot of modifying existing, working code everytime a new change is brought in to place.

### The general points I had learned during this exercise were the following:
- Localised updates to the codebase shouldn't cause non-local side effects.
- Prevent code duplication across subclasses.
- Make code understandable and easy to locate, users shouldn't have to navigate every subclass to learn the behaviours of a specific duck.
- Ensure code changes to one duck do not inadvertently affect another duck.

### During this exercise I followed the below principles in order to pinpoint areas of improvement:
- Identify parts of your application that vary and separate them from code that stays the same.
- Take what varies and encapsulate it to prevent it affecting the rest of your code.
- Program to an interface, not an implementation.

### Based on these findings I did the following:
- Extracted duck functionality (Quacks, flying etc.) in to behaviour classes.
- Managed interaction with said classes via a behaviour interface (i.e. IFlyBehaviour, IQuackBehaviour)
- Set behaviour type to a subclass on its initialisation.

As a result we now have a class/subclass structure that is runtime dynamic with little code re-use and less side effects when we go in to add or edit function.

## References
https://www.amazon.co.uk/Head-First-Design-Patterns-Object-Oriented/dp/149207800X/
https://www.tutorialspoint.com/design_pattern/strategy_pattern.htm
