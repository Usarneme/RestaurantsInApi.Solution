# RestaurantsInApi.Solution

### By Tom/Usarneme


A C# web API for getting and setting data about Restaurants in your town. Allows anyone to create a Restaurant and City and add a Restaurant to a City.

---

## Technologies Used

1. C#
2. .NET
3. ASP.NET Core
4. Swagger/Swagger-UI via Swashbuckle
5. Postman
6. Visual Studio Code

---


### Requirements

1. C#/.NET - packages and instructions for installation for your OS are available at [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. A web browser of your choice, such as [Firefox](https://www.mozilla.org/en-US/firefox/new/)

---

### Installation Instructions

1. Clone this repository `git clone https://github.com/Usarneme/RestaurantsInApi.Solution`
2. Enter the project directory `cd RestaurantsInApi.Solution/RestaurantsInApi`
3. Install dependencies with `dotnet restore`
4. Create a file called appsettings.json that contains your connection string for your MySql installation; `touch appsettings.json` then, for example, `nano appsettings.json` and then paste the following into this file:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft": "Warning",
      "Microsoft.Hosting.Lifetime": "Information"
    }
  },
  "AllowedHosts": "*"
}
```

5. Start the web server with `dotnet run`
6. Visit the website in your browser of choice (see console for details), typically at http://localhost:5000/

NOTE: If you have trouble accessing the website it is likely because your browser is warning you about an invalid SSL certificate. This project redirects you to an HTTPS site at port 5001 by default. Please check your browser's website for instructions on bypassing this warning; for example in Firefox you must Click on the Advanced button and then the "I understand the risks, take me to the site" link that will appear below the warning text. This app uses the default C# SSL certificate because this is a learning project; were it hosted on a real website it would require a real SSL cert to comply with browser security requirements.

---

### API Documentation

Explore the API endpoints utilizing the built-in Swagger-UI. After running the application (see steps above), in your browser navigate to `http://localhost:5000/swagger/index.html` to view, inspect, and test all endpoints.

A complete listing of all endpoints with route parameter requirements is as follows:
```
{
  "openapi": "3.0.1",
  "info": {
    "title": "RestaurantsInApi",
    "version": "v1"
  },
  "paths": {
    "/api/Cities": {
      "get": {
        "tags": [
          "Cities"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/City"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/City"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/City"
                  }
                }
              }
            }
          }
        }
      },
      "post": {
        "tags": [
          "Cities"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/City"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/City"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/City"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              }
            }
          }
        }
      }
    },
    "/api/Cities/{id}": {
      "get": {
        "tags": [
          "Cities"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              }
            }
          }
        }
      },
      "put": {
        "tags": [
          "Cities"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/City"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/City"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/City"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "delete": {
        "tags": [
          "Cities"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Cities/random": {
      "get": {
        "tags": [
          "Cities"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              }
            }
          }
        }
      }
    },
    "/api/Cities/search/{query}": {
      "get": {
        "tags": [
          "Cities"
        ],
        "parameters": [
          {
            "name": "query",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/City"
                }
              }
            }
          }
        }
      }
    },
    "/api/Restaurants": {
      "get": {
        "tags": [
          "Restaurants"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Restaurant"
                  }
                }
              },
              "application/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Restaurant"
                  }
                }
              },
              "text/json": {
                "schema": {
                  "type": "array",
                  "items": {
                    "$ref": "#/components/schemas/Restaurant"
                  }
                }
              }
            }
          }
        }
      },
      "post": {
        "tags": [
          "Restaurants"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Restaurant"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Restaurant"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Restaurant"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              }
            }
          }
        }
      }
    },
    "/api/Restaurants/{id}": {
      "get": {
        "tags": [
          "Restaurants"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              }
            }
          }
        }
      },
      "put": {
        "tags": [
          "Restaurants"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/Restaurant"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/Restaurant"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/Restaurant"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      },
      "delete": {
        "tags": [
          "Restaurants"
        ],
        "parameters": [
          {
            "name": "id",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/api/Restaurants/random": {
      "get": {
        "tags": [
          "Restaurants"
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              }
            }
          }
        }
      }
    },
    "/api/Restaurants/search/{query}": {
      "get": {
        "tags": [
          "Restaurants"
        ],
        "parameters": [
          {
            "name": "query",
            "in": "path",
            "required": true,
            "schema": {
              "type": "string",
              "nullable": true
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "content": {
              "text/plain": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              },
              "text/json": {
                "schema": {
                  "$ref": "#/components/schemas/Restaurant"
                }
              }
            }
          }
        }
      }
    }
  },
  "components": {
    "schemas": {
      "Restaurant": {
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "nullable": true
          },
          "name": {
            "type": "string",
            "nullable": true
          },
          "description": {
            "type": "string",
            "nullable": true
          },
          "longitude": {
            "type": "number",
            "format": "float"
          },
          "latitude": {
            "type": "number",
            "format": "float"
          },
          "menu": {
            "type": "string",
            "nullable": true
          }
        },
        "additionalProperties": false
      },
      "City": {
        "type": "object",
        "properties": {
          "id": {
            "type": "string",
            "nullable": true
          },
          "name": {
            "type": "string",
            "nullable": true
          },
          "description": {
            "type": "string",
            "nullable": true
          },
          "longitude": {
            "type": "number",
            "format": "float"
          },
          "latitude": {
            "type": "number",
            "format": "float"
          },
          "state": {
            "type": "string",
            "nullable": true
          },
          "restaurants": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/Restaurant"
            },
            "nullable": true
          }
        },
        "additionalProperties": false
      }
    }
  }
}
```

NOTE: CORS (cross origin resource sharing, [more here](https://developer.mozilla.org/en-US/docs/Web/HTTP/CORS)) is enabled for this application however all hosts (access points/clients) are allowed by default as this is a testing app. If it were production CORS allowed hosts settings can be managed in the created appsettings.json file in the project directory. See [this MS Docs page](https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-5.0) for specifics on configuring CORS allowed hosts.

---

### License

GPLv3 - No Copyright

---

### Bugs

No known issues at this time. Please submit a pull request/add to the issue tracker above if you find something out of place.

Thanks!