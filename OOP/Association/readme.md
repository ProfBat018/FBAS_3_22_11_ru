# Тема урока. Агрегация и Композиция

### Агрегация - это когда один объект может содержать в себе другой объект, но при этом объекты могут существовать и независимо друг от друга. Нужно понимать что в данном случае мы по хорошему должны хранить ссылку на другой объект. 

Вы это уже делали в дз с компьютером и комплектующими.
Но есть важный момент. Если объект чужого класса создается и удаляется внутри другого объекта, то это `композиция`. Если же объект создается вне другого объекта и передается ему в качестве параметра, то это агрегация.