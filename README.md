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
7. Token authentication via JWT

---


### Requirements

1. C#/.NET - packages and instructions for installation for your OS are available at [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. A web browser of your choice, such as [Firefox](https://www.mozilla.org/en-US/firefox/new/)
3. (Optional) For access to authenticated routes you must pass an auth token (JWT) using Postman. Instructions to download and install Postman [are available here](https://www.postman.com/downloads/).

---

### Installation Instructions

1. Clone this repository `git clone https://github.com/Usarneme/RestaurantsInApi.Solution`
2. Enter the project directory `cd RestaurantsInApi.Solution/RestaurantsInApi`
3. Install dependencies with `dotnet restore`
4. Create a file called appsettings.json to control startup aspects of the application; `touch appsettings.json` then, for example, `nano appsettings.json` and then paste the following into this file:

```
{
  "AppSettings": {
    "Secret": "THIS IS USED TO SIGN AND VERIFY JWT TOKENS. It can be any string but not too short or you will get an error."
  },
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
6. Open your browser of choice and navigate to `http://localhost:4000/swagger/index.html` to view, inspect, and test all endpoints.
7. (Optional) You may also use [Postman](https://www.postman.com/downloads/) to view and test all api endpoints.

NOTE: If you have trouble accessing the website it is likely because your browser is warning you about an invalid SSL certificate. This project may redirect you to an HTTPS site at, for example, port 5001. Please check your browser's website for instructions on bypassing this warning; for example in Firefox you must Click on the Advanced button and then the "I understand the risks, take me to the site" link that will appear below the warning text. This app uses the default C# SSL certificate because this is a learning project; were it hosted on a real website it would require a real SSL cert to comply with browser security requirements.

---

### API Documentation

Explore the API endpoints utilizing the built-in Swagger-UI. After running the application (see steps above), in your browser navigate to `http://localhost:4000/swagger/index.html` to view, inspect, and test all endpoints.

Please note that the only route currently requiring authentication is `/users`. In order to access the users list you must be authenticated and pass the appropriate JWT token created after authenticating. This is not possible using the Swagger-UI and can only be accomplished via [Postman](https://www.postman.com/downloads/).

To access the authenticated `/Users` route you must pass a Bearer token; which JWT is only obtainable by first making a get request to `/Users/authenticate`. In Swagger-UI send a GET request to this route passing the following request body:
```
{
  "username": "test",
  "password": "test"
}
```

This will return a response body similar to:
```
{
  "id": 1,
  "firstName": "Test",
  "lastName": "User",
  "username": "test",
  "token": "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZ...etc...DQ2Mjc1fQ.J2GaaAOpKIYP6YIaXZ-f3SgXP9XKB3GXYnaB8Ue4j28"
}
```

Copy the Token from this response.

* Open Postman,
* select a new query directed to the route `localhost:4000/users`,
* select GET from the HTTP verbs drop-down list,
* navigate to the Authorization tab,
* from the Type drop-down list select "Bearer"
* and paste the copied token into the Token field to the right.
* Finally, hit the blue Send button to see the results of your JWT-authorized request.

A complete listing of all endpoints with route parameter requirements is as follows:
```
{
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
    },
    "/Users/authenticate": {
      "post": {
        "tags": [
          "Users"
        ],
        "requestBody": {
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/AuthenticateRequest"
              }
            },
            "text/json": {
              "schema": {
                "$ref": "#/components/schemas/AuthenticateRequest"
              }
            },
            "application/*+json": {
              "schema": {
                "$ref": "#/components/schemas/AuthenticateRequest"
              }
            }
          }
        },
        "responses": {
          "200": {
            "description": "Success"
          }
        }
      }
    },
    "/Users": {
      "get": {
        "tags": [
          "Users"
        ],
        "responses": {
          "200": {
            "description": "Success"
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
      },
      "AuthenticateRequest": {
        "required": [
          "password",
          "username"
        ],
        "type": "object",
        "properties": {
          "username": {
            "type": "string"
          },
          "password": {
            "type": "string"
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