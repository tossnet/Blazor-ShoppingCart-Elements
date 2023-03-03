# AngularShoppingCart

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 15.1.6.

## Development server

Run `ng serve` for a dev server. Navigate to `http://localhost:4200/`. The application will automatically reload if you change any of the source files.

## Code scaffolding

Run `ng generate component component-name` to generate a new component. You can also use `ng generate directive|pipe|service|class|guard|interface|enum|module`.

## Build

Run `ng build` to build the project. The build artifacts will be stored in the `dist/` directory.

## CE
Dans angular.json : ajouter 
"src/_framework",
"src/_content"


          "assets": [
              "src/favicon.ico",
              "src/assets",
              "src/_framework",
              "src/_content"
            ],


Dans src/index.html :

  <link href="Blazor.ShoppingCart.Wasm.styles.css" rel="stylesheet" />
  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
</head>
<body>
  <script src="_framework/blazor.webassembly.js" autostart="true"></script>

  <app-root></app-root>

Dans src/app/app.module.ts modifier en ajoutant "CUSTOM_ELEMENTS_SCHEMA" :

       import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

et plus bas : 
      
        schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
