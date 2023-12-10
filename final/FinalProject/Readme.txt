FinalProject program readme file

> > > Overview:
> > Description/Origin: This program is designed to, under direction from the user, record a bunch of data within a structure that could be thought of like a file-system where data is in containers and those containers are in other containers. The data can be of different types and the containers can be of different types, and the user is able to add to the data structure and view pieces of the structure. The idea comes from a Dungeons & Dragons "Character Sheet" which contains various pieces (and types) of information grouped together in various ways, each of which may need to be reviewed under various sets of circumstances. This program has the flexibility to allow someone to create such a character sheet, or any of many other types of information structures, as well as to choose what information it contains and to view parts of the structure.
> > A few Details: While using the program, the user will always be "in" or "navigated to" either one container or one piece of data. The user will be shown a menu with options relevant to whatevery they are in: if navigated to a piece of data, the user can view the data; if navigated to a container, the user can view the container's contents, add stuff to the container, and remove stuff to the container. The user always has navigation options, allowing them to move "up" through layers of data and containers (i.e. moving "out" of a piece of data or a container into whatever container it is inside) or, if they are in a container that contains something, allowing them to move "down" into someting that is in their current container.
> > Note: Containers and pieces of data are both referred to as "elements"; as such, a container can simply be said to "contain elements", or the user could be said to "navigate to an element". Each element has a name.

> > > The Elements:
> > Container types:
> Sheet—The starting container. There is a single sheet, and everything else is an element thereof.
> Box—The standard container. Boxes hold data.
> BonusBox—The special container. BonusBoxes function like the other containers except that the user does not see a BonusBox's contents when viewing a section of the Sheet that the bonus box is in. You can only see a BonusBox's contents when navigated to the BonusBox.
> > Datum types:
> Number—Numeric data. Cannot hold complex numbers or fractions.
> Text—Textual data. If you want to enter multi-line data, consider copying & pasting the line break from somewhere; trying to just type it will probably just submit whatever you have already typed.
> BonusText—Hidden-ish textual data. Like a BonusBox, but for text: The user does not see a BunusText's value (the text) when viewing a section of the Sheet that the BonusText is in. You can only see a BonusText's value when navigated to the BonusText. (There is currently no BonusNumber, but there's also not much of a difference between Text's and Number's at the moment anyway, so you can probably use a BonusText anywhere you would like to use a BonusNumber.)

> > > Menu options:
> > Display options:
> Display data value: Displays the value of the data.
> List container contents: Allows the user to enter a number of "layers" they will view. The user is shown the container contents and, if the number was 2 or more, the contents' contents and, if the number was 3 or more, the contents' contents' contents, and so on. (BonusElements will not be seen into unless they are the contents of the container that is navigated to.)
> > Add element (Container option): Adds an element to the container. The user chooses the type of element, its name, and, if it is a data element, the value.
> > Remove element (Container option): Deletes an element from within the container. The user chooses the number of the element to be deleted—numbers cannot currently be viewed, but they align with how the elements display. (E.g. if a container with elements A, B, and C display in that order, then A is element 1, B is 2, and C is 3.)
> > Navigation options:
> Navigate down (Container option): Let's the user navigate down withing an element of the container they are currently in and view that element's menu. You cannot navigate down from within an empty container. The user chooses the number of the element to be navigated to—numbers cannot currently be viewed, but they align with how the elements display. (E.g. if a container with elements A, B, and C display in that order, then A is element 1, B is 2, and C is 3.)
> Navigate up: Let's the user navigate back to a container that holds the element they are currently navigated to. The user can move up through multiple "layers" of elements at once, but will never be able to move "above" the Sheet. The Sheet has an option to end the program in place of an option to navigate higher up.

