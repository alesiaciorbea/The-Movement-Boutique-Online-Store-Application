# The Movement Boutique

The application is structured into two main components: the admin interface and the client interface, with role-based access determined at login. User authentication is handled via a login form, and the interface adapts based on the authenticated user's role (administrator or client).

The administrator has full control over the product inventory and orders. Admin functionalities include:
- Adding, editing, and deleting products from the SQL Server database.
- Viewing, finalizing, or deleting customer orders.

The client can:
- Browse available products grouped by category.
- Add items to a shopping cart.
- Place an order by providing a delivery address, selecting a payment method, and choosing a delivery type.

The system manages a stock of unique items (each product exists only once in the database). When a product is added to a client’s cart, it is temporarily reserved and hidden from other users. If the order is finalized, the item remains reserved until processed or removed by the administrator. If not purchased, the product becomes available again for other users.

All data is stored and managed using a relational database with tables for users, products, orders, and order details. The application is developed in C# using Windows Forms, with image handling, category filtering, and dynamic interface updates based on user actions.
