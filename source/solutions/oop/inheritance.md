---
tags:
- oop/uml
- oop/objects
---

# Inheritance (Solutions)

## Questions

#. What is the keyword used to call the constructor from the base class?

  - [ ] `this`.
  - [ ] the name of the base class.
  - [x] `base`
  - [ ] `over`
  - [ ] `inherits`


## Problems

#. Consider the diagram representing the "Room", "ClassRoom", "Office" classes and their relations.

  !include uml/cla/RoomClassroomOffice.md

  Suppose you are given an implementation of the `Room` class, such that 

  ```
  !include`snippetStart="// Question 1",snippetEnd="// Refer to Classroom.cs for a solution"` code/projects/RoomClassroomOffice/RoomClassroomOffice/Program.cs
  ```

  displays

  ```text
  UH 243
  ```

  #. Write an implementation of the `ClassRoom` class. Your `ToString` method should display the room's building and number, in addition to whether it has AV set-up.

      <details><summary>Solution</summary>
      ```
      !include code/projects/RoomClassroomOffice/RoomClassroomOffice/Classroom.cs
      ```
      </details>

  #. Write a `SameBuilding` static method to be placed inside the `Room` class such that

      ```
      !include`snippetStart="// Question 2",snippetEnd="// Refer to Room.cs for a solution.",dedent=4` code/projects/RoomClassroomOffice/RoomClassroomOffice/Program.cs
      ```
      Would display "true" and "false".
      
      <details><summary>Solution</summary>
      ```
      !include`snippetStart="// (not on UML diagram)",snippetEnd="// Note that since we are inside the class,"` code/projects/RoomClassroomOffice/RoomClassroomOffice/Room.cs
      ```
      </details>

#. Consider the diagram representing the "Article", "Book" classes and their relations.

      !include uml/cla/Article.md

    #. Write a (partial) implementation of the `Article` abstract class:

        #. Write an implementation for the `price` attribute: you can either use a getter and a setter (as pictured in the UML diagram), or a property. However, in both cases, setting the price to a negative value should result in an `ArgumentOutOfRangeException` exception being thrown.
        #. Write an *abstract* `ShippingCosts()` method.

        <details><summary>Solution</summary>
        ```
        !include code/projects/Article/Article/Article.cs
        ```
        </details>

        
    #. Now, assume given a complete implementation of the `Article` abstract class. Write a **complete** implementation of the `Book` class (header included), containing:
        #. An implementation of the `Title` property using auto-properties.
        #. A `Book` constructor that passes the `idP` and `priceP` arguments to the `Article` constructor. The `titleP` argument should be assigned to the `Title` property.
        #. A `ShippingCosts()` method that returns either 5.0, or 10% of the Book's price, whichever is smallest.
    
        <details><summary>Solution</summary>
        ```
        !include code/projects/Article/Article/Book.cs
        ```
        </details>
    
    #. Write statements that, if placed in a `Main` method, would
        #. Create a `Book` with `Id` "AAA001", `price` $12.5, titled "What it's like to be a bird".
        #. Display (nicely) its shipping costs.
        #. Display its `Id` (as retrieved from the object).

        <details><summary>Solution</summary>
        ```{download="code/projects/Article.zip"}
        !include code/projects/Article/Article/Program.cs
        ```
        </details>

