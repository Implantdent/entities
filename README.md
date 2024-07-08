# Entities

Proyecto con las entidades que corresponden a las tablas de la base de datos que soporta la aplicación ImplantDent

| Sonarqube |
|---|
| [![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=Implantdent_entities&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=Implantdent_entities) |
| [![Bugs](https://sonarcloud.io/api/project_badges/measure?project=Implantdent_entities&metric=bugs)](https://sonarcloud.io/summary/new_code?id=Implantdent_entities) |
| [![Code Smells](https://sonarcloud.io/api/project_badges/measure?project=Implantdent_entities&metric=code_smells)](https://sonarcloud.io/summary/new_code?id=Implantdent_entities) |
| [![Coverage](https://sonarcloud.io/api/project_badges/measure?project=Implantdent_entities&metric=coverage)](https://sonarcloud.io/summary/new_code?id=Implantdent_entities) |


## CI/CD

Se ejecuta el pipeline https://github.com/Implantdent/entities/actions/workflows/build.yml

| Rama | Estado |
|:-:|:-:|
| dev | [![Compilar](https://github.com/Implantdent/entities/actions/workflows/build.yml/badge.svg?branch=dev)](https://github.com/Implantdent/entities/actions/workflows/build.yml) |
| qa | [![Compilar](https://github.com/Implantdent/entities/actions/workflows/build.yml/badge.svg?branch=qa)](https://github.com/Implantdent/entities/actions/workflows/build.yml) |
| main | [![Compilar](https://github.com/Implantdent/entities/actions/workflows/build.yml/badge.svg?branch=main)](https://github.com/Implantdent/entities/actions/workflows/build.yml) |

El despliegue se ejecuta en

| Rama | NuGet |
|:-:|:-:|
| dev | Entites 1.0.X-dev |
| qa | Entites 1.0.X-qa |
| main | Entites 1.0.X |

## Lenguaje

C# .Net 8

## Librerías y paquetes

| Paquete | Versión |
|:-:|:-:|
| xUnit | 2.5.3 |

## Compilar y probar

Se ejecuta el proyecto de pruebas Entities.Test