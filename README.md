# Online Bookstore README

## Introduction

Welcome to the Online Bookstore project! This project is a simple online bookstore application that provides three main endpoints: 

1. `GET /books`: Retrieve a list of available books.
2. `GET /book/{id}`: Retrieve detailed information about a specific book.
3. `POST /order`: Place an order for one or more books.

In addition to these endpoints, the project integrates with RabbitMQ for messaging capabilities. When a new order is placed, it sends a message about the order to another project called the "Order Processing Service" via RabbitMQ.
which is a console application
## Getting Started

Follow the instructions below to set up and run the Online Bookstore project:

### Prerequisites

1. Docker: Ensure that you have Docker installed on your system. You can download it from [Docker's official website](https://www.docker.com/get-started).

### Installation

1. Clone the Online Bookstore project repository to your local machine.

   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory.

   ```bash
   cd online-bookstore
   ```
3.Launch Docker Desktop. 

4. Build the Docker image for the Online Bookstore application.

   ```bash
   docker-compose up
   ```

### Running the Application

1.Build and run the application. Make sure both the api and console application are set as startup projects.

## Usage

You can interact with the Online Bookstore using the following endpoints:

- `GET http://localhost:8080/books`: Retrieve a list of available books.
- `GET http://localhost:8080/book/{id}`: Retrieve detailed information about a specific book by replacing `{id}` with the book's ID.
- `POST http://localhost:8080/order`: Place an order for one or more books. Provide the necessary order details in the request body.

## Messaging with RabbitMQ

The Online Bookstore project uses RabbitMQ for messaging. When a new order is placed using the `/order` endpoint, a message is sent to the "Order Processing Service" via RabbitMQ. The "Order Processing Service" is set up to listen for and process these messages.

## Contact

If you have any questions or need further assistance, please contact us at [abrahammicheal55@yahoo.com](mailto:abrahammicheal55@yahoo.com).

Thank you for using the Online Bookstore project! Happy reading and coding!
