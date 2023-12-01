# Router and Route Calculation System

## Introduction
This code defines classes to manage routers and calculate the best route among available options. Below is a breakdown of the classes and their functionalities.

### Classes

#### Router
- **Properties**:
  - `Xvalue`: Represents a router value.

#### Route
- **Properties**:
  - `myRouter`: An instance of the Router class.
  - `myArray`: An array of Router instances.

- **Methods**:
  - `AddInput()`: Adds routers to a given route by taking user input.

#### Sync_Async
- **Properties**:
  - `myRoute`: An instance of the Route class.

- **Methods**:
  - `Calcuates()`: Synchronous method to calculate the best route from available routes.
  - `Calculates_async()`: Asynchronous method using Task.Run to perform the calculation asynchronously.

### Usage
1. **Router and Route Setup**:
   - Create Router instances and add them to the Route using the `AddInput()` method.

2. **Synchronous Calculation**:
   - Use the `Calcuates()` method to calculate the best route synchronously.

3. **Asynchronous Calculation**:
   - Utilize the `Calculates_async()` method to perform the calculation asynchronously using Task.Run.

4. **Main Program**:
   - The `Main()` function sets up routes, initiates synchronous calculation, and demonstrates asynchronous calculation.

## Additional Notes
- The code presents a basic implementation of router management and route calculation.
- For more complex scenarios or real-world use, further enhancements and error handling might be necessary.
