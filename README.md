# _Word Counter_

#### _A project for demonstrating knowledge of BDD with C# for Epicodus that counts how many times a given word appears in a string, 12/1/2016_

#### By _**Bryant Wang**_

## BDD Specs


| Behavior                                                                                                                          | Description                                                                                                        | Input                                          | Output |
|-----------------------------------------------------------------------------------------------------------------------------------|--------------------------------------------------------------------------------------------------------------------|------------------------------------------------|--------|
| The program will accept a single word string as input and check if it contains itself.                                            | Input value chosen as it's a simple single word.                                                                   | This                                           | True   |
| The program will accept two single word strings as input and check if the second contains the first.                              | Second input value chosen as it's a duplicate of the first.                                                        | This, This                                     | True   |
| The program will accept two strings as input and check if the second multi-word input contains the first single-word input.       | Sentence chosen because it's a simple sentence that contains the test word.                                        | This, This is a simple sentence                | True   |
| The program will handle input with different casing.                                                                              | Sentence all lower-cased to see if the program can still recognize the first word inside with inconsistent casing. | This, this is a simple sentence                | True   |
| The program will handle input with non letter characters.                                                                         | Quotations and comma added especially because they are directly adjacent to the input word with no spaces.         | This, "This, is a simple sentence!?"           | True   |
| If the second string contains the first, the program will count how many times the first word appears in the second string input. | Input word appears twice in sentence to make sure it can count more than one.                                      | This, "This is a simple sentence is this not?" | 2      |

## Technologies Used

_C#, Nancy, Razor_

### License

*GPL*

Copyright (c) 2016 **_Bryant Wang_**
