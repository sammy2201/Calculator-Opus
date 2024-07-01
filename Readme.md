## Introduction

This is a simple text calculator that can sum up numbers provided as a comma-separated string.
It includes a backend API implemented with .NET Core and a frontend web interface.

## Prerequisites

- .NET SDK
- A web browser

## Install Dependencies

cd TextCalculatorApp
dotnet restore
cd ../TextCalculatorAPI
dotnet restore
cd ../TextCalculatorTests
dotnet restore

## run tests

cd TextCalculatorTests
dotnet test

## run API

cd TextCalculatorAPI
dotnet run

## Open the Web Frontend

Open TextCalculatorFrontend/index.html in your browser.

## Usage

1. Enter numbers separated by commas in the input field.
2. Click "Calculate" to see the sum of the numbers.
