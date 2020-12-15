import requests
import json


basicURL = "http://localhost:55336/api"

foods = [
    {
        "Name": "Feijão tropeiro",
        "Price": 10,
        "TimeToPrepare": 3000,
        "HasIngredients": [
            {
                "IngredientId": 1
            },
            {
                "IngredientId": 2
            },
            {
                "IngredientId": 3
            },
        ]
    },
    {
        "Name": "Feijão preto",
        "Price": 9.90,
        "TimeToPrepare": 2500,
        "HasIngredients": [
            {
            "IngredientId": 1
            },
            {
                "IngredientId": 2
            },
            {
                "IngredientId": 3
            },
        ]
    }
]

ingredients = [
    {
        "Name": "Arroz"
    },
    {
        "Name": "Feijão"
    },
    {
        "Name": "Linguiça"
    }
]

drinks = [
    {
        "Name": "Skol 1L",
        "Price": 11,
        "TimeToPrepare": 200
    },
    {
        "Name": "Vinho tinto 1L",
        "Price": 22,
        "TimeToPrepare": 200
    }
]


for ingredient in ingredients:
    requests.post(basicURL + "/Ingredients", json.dumps(ingredient))

for food in foods:
    requests.post(basicURL + "/Foods", json.dumps(food))

for drink in drinks:
    requests.post(basicURL + "/Drinks", json.dumps(drink))