# Fast Food Ordering System:
## Comprising the interfaces of 4 subsystems:
- Partner: branch management form, menu management form, order management form, contract management form.
- Employee: contract processing form.
- Customer: food item list form, branch list form, order form.
- Driver: order processing form.
  
## Conflict situations and error handling:
Dirty Read: Customers view the list of orders simultaneously when the partner updates the order status.
Lost update: Customers place orders simultaneously when the partner updates the order status.
Unrepeatable read: Partner views the list of contracts simultaneously when an employee extends a contract.
Phantom: Customers view the menu list simultaneously when the partner updates the restaurant's menu.

## Prerequisites:
Run 2 files Database.sql and ProcedureList.sql.
Edit the connectionString in App.config with the current Server ID.
