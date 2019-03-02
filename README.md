PP2
Lecture Week 5 
1. Show file and folder count in directory
2. Show count of txt files example
3.
4. Palindrome
5. Size

Example of class and instance (PurchaseOrder)

PurchaseOrder:
    Address
    OrderDate
    OrderItems

Address:
    Name
    City
    State 
    Zip

OrderItem:
    ItemName
    Description
    UnitPrice
    Quantity
    LineTotal (UnitPrice * Quantity)

Example of read/write this class from input/output files

Example of architecture of microservices (serialization)
XmlSerializer
[XmlArray("Items")]
[XmlIgnore]

try catch finally

#6 Lecture Notes (Snake)

1. Console
    Clear
    SetCursorPosition
    CursorVisible

2. * up, down, left, right
3. Inheritance example (Shape)
4. Game architecture (snake, wall, food)
5. GameObject
    List<Point> body
    char sign
    public ConsoleColor
    GameObject(Point firstPoint, ConsoleColor color, char sign)
    Draw()

6. Snake:GameObject (add Move function)
7. Food:GameObject
8. Wall:GameObject (add LoadLevel function)
9. Game class
    Snake snake;
    Food food;
    Wall wall;
    bool isAlive
    List<GameObject> g_objects
    enum GameLevel {
        FIRST,
        SECOND,
        THIRD
    }
    GameLevel gameLevel;
    SetupBoard()
    Game() - init all data
    Draw()
    Exit()
    Start()
    Save()
    Load()




