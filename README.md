# Тестовое задание для Sense Capital.

## Описание API

![image](https://user-images.githubusercontent.com/56086653/224211497-db84f86b-f1eb-4a89-ae00-6b91f4418e36.png)

## **1.Player-ресурс**

> | Метод | Endpoint                | Назначение                          |
> |-------|-------------------------|-------------------------------------|
> | POST  | api/Player/CreatePlayer | Создает игрока с данным именем      |
>
> **Request:**
>
> ```
> {
>   "name": "string"
> }
> ```
>
>**Response:**
> ```
> {
>  "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>  "name": "string"
> }
> ```

> | Метод | Endpoint                | Назначение                          |
> |-------|-------------------------|-------------------------------------|
> | GET   | api/Player/{id}         | Возвращает игрока с определенным Id |
>
> **Request:**
>
> ```
> ```
>
> **Response:**
> ```
> {
>   "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>   "name": "string"
> }
> ```

---

## **2.Game-ресурс**

> | Метод | Endpoint            | Назначение                        |
> |-------|---------------------|-----------------------------------|
> | POST  | api/Game/CreateGame | Создает игру с данным игроками    |
>
>
> **Request:**
> 
> ```
> {
>   "playerOneId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>   "playerTwoId": "3fa85f64-5717-4562-b3fc-2c963f66afa6"
> }
> ```
> 
> **Response:**
> ```
> {
>   "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>   "playerOne": {
>     "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>     "name": "string",
>     "movementValue": "string"
>   },
>   "playerTwo": {
>     "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>     "name": "string",
>     "movementValue": "string"
>   }
> }
> ```

> | Метод | Endpoint            | Назначение                        |
> |-------|---------------------|-----------------------------------|
> | GET   | api/Game/{id}       | Возвращает игру с определенным id |
> 
> **Request:**
> ```
> {
> }
> ```
> 
> **Response:**
> ```
> {
>   "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>   "playerOne": {
>     "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>     "name": "string",
>    "movementValue": "string"
>   },
>   "playerTwo": {
>     "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>     "name": "string",
>    "movementValue": "string"
>   }
> }
> ```

---

## **3.Movement-ресурс**

> | Метод | Endpoint              | Назначение                                                                                   |
> |-------|-----------------------|----------------------------------------------------------------------------------------------|
> | POST  | api/Movement/MakeMove | Заполняет определенную клетку игрового поля, возвращает текущее состояние игры и игровое поле |
> 
> **Request:**
> ```
> {
>  "gameId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>   "playerId": "3fa85f64-5717-4562-b3fc-2c963f66afa6",
>   "position": 0
> }
> ```
> 
> **Response:**
> ```
> {
>   "status": 0,
>   "field": "string"
> }
> ```
