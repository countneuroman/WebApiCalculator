"use strict";

const uri = "CalculationNumber";

async function calculate() {
    const num1 = document.getElementById("add-num1");
    const num2 = document.getElementById("add-num2");
    const operation = document.getElementById("operation");

    const item = {
        num1: Number(num1.value.trim()),
        num2: Number(num2.value.trim()),
        operation: String(operation.value.trim())
    };

    await fetch(uri, {
        method: "POST",
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
        body: JSON.stringify(item)
    })
    .then(response => response.json())
    .then(data => alert(data))
    .catch(error => console.error("Unable to get data", error));
}