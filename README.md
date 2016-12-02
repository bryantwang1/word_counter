# _Word Counter_

#### _A project for demonstrating knowledge of BDD with C# for Epicodus that counts how many times a given word appears in a string, 12/1/2016_

#### By _**Bryant Wang**_

## BDD Specs

| Behavior                                                                                                           | Description                                                                                                        | Input                                            | Output |
|--------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|--------------------------------------------------|--------|
| The program will accept a single word string as input and returns 1 if it contains itself.                         | Input value chosen as it's a simple single word.                                                                   | This                                             | 1      |
| The program will accept two single word strings as input and returns 1 if the second contains the first.           | Second input value chosen as it's a duplicate of the first.                                                        | This, This                                       | 1      |
| The program will accept two strings as input and count the number of times the first string appears in the second. | Sentence chosen because it's a simple sentence that contains the test word more than once.                         | This, This is a simple sentence is this not      | 2      |
| The program will handle input with different casing.                                                               | Sentence all lower-cased to see if the program can still recognize the first word inside with inconsistent casing. | This, this is a simple sentence is this not      | 2      |
| The program will handle input with non letter characters.                                                          | Quotations and comma added especially because they are directly adjacent to the input word with no spaces.         | This, "This, is a simple sentence is this not!?" | 2      |

## Technologies Used

_C#, Nancy, Razor_

### License

*GPL*

Copyright (c) 2016 **_Bryant Wang_**
