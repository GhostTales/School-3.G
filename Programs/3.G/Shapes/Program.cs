Circle2D circle = new Circle2D(12);
Shape2D circle2 = new Circle2D(11);
Console.WriteLine($"{circle} | area: {circle.Area} | circumference {circle.Circumference}");
Console.WriteLine($"{circle2} | area: {circle2.Area} | circumference {circle2.Circumference}");

Triangle2D triangle = new Triangle2D(6, 3);
Shape2D triangle2 = new Triangle2D(6, 4);
Console.WriteLine($"{triangle} | area: {triangle.Area} | circumference {triangle.Circumference}");
Console.WriteLine($"{triangle2} | area: {triangle2.Area} | circumference {triangle2.Circumference}");

Rectangle2D rect = new Rectangle2D(5, 5);
Shape2D rect2 = new Rectangle2D(5, 4);
Console.WriteLine($"{rect} | area: {rect.Area} | circumference {rect.Circumference}");
Console.WriteLine($"{rect2} | area: {rect2.Area} | circumference {rect2.Circumference}");

Square2D square = new Square2D(5);
Rectangle2D square2 = new Square2D(6);
Shape2D square3 = new Square2D(7);
Console.WriteLine($"{square} | area: {square.Area} | circumference {square.Circumference}");
Console.WriteLine($"{square2} | area: {square2.Area} | circumference {square2.Circumference}");
Console.WriteLine($"{square3} | area: {square3.Area} | circumference {square3.Circumference}");
