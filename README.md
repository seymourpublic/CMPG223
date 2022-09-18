# CMPG223
v3
NAMES
Naledi Sandamela 31816339                                                                                                Ntjie Magongwa 32374697                                                                                                  Ofentse Dibetso 31855016                                                                                                                              




















# SYSTEM DESCRIPTION
## PROBLEM STATEMENT
We all know that getting textbooks can be a problem, because its expensive and it is a race against time due to limited stock. The current system works on a paper system to keep track of student and textbook details.
Our system focuses on three problems the current system has:
•	Paper System (this will be automated)
•	Expensive textbooks
•	Limited Stock
# SOLUTION 
Our system aims to fix this problem by providing students with a platform (where a user uses the kiosk to decide on their purchase) where they have a choice to whether buy the textbook or rent it out on a negotiated payment plan, they will discuss with the bookstore, these textbooks will be given or sold to us by senior student as they are not using them anymore. Our system will make sure that each student (that wants a hardcopy textbook) gets a textbook. The textbook is then return to the shop and the senior students receive a portion of the money, whenever the textbook is lost or returned damaged the student will receive a fine.
# SCOPE DEFINITION
•	Maintain clients
•	Maintain textbooks
•	Receive textbook
•	Sell Textbook
•	Return textbook
•	Rent a textbook
•	Request Reports (this will be elaborate later) 
•	Backup of Data

## LOGIN PAGE
This event happens when a user logs onto our system. The system verifies the user’s password for existing clients and allows new clients to add a new profile.
 
## MAINTAIN CLIENTS
This event happens when the bookstore administrator wants to add a new client, change any clients’ details and remove clients.



## MAINTAIN TEXTBOOKS
This event happens when the bookstore administrator wants to add a new textbook, change its details like the status and availability and remove old version textbooks.










## RENT
This event happens when the bookstore receives a textbook from a senior student. The student can choose whether they want to sell us the textbook or give it to us for free.
 





## SELL TEXTBOOKS
This happens when we sell our textbooks to students. The student can choose whether they want to buy or rent it out.
 


## RETURN TEXTBOOKS
The student returns the textbook to us, on the condition that if they lost or damaged (to a certain extent) the textbook the student pays a fine. Apart from that the senior students receive a portion of the money.
 






## CHANGE OF STATUS
This event happens when the bookstore wants to change the status of the textbook, whenever it is damaged or lost.








# SQL
Clients
 
Textbooks Received
 
Rented Out
 
Returned
 
Textbooks Sold
 
Textbooks
 


Insert
 

Update
 

Delete
 

Report
 

Search
 


# Process Model


# DATA model



# ENTITIES
•	Clients
o	Student number (PK)
o	Name
o	Surname
o	Course
o	Cell Phone Number
•	Textbook
o	Book_ID(PK)
o	Price
o	Textbook_Name
o	Module code
o	Quantity
•	Receive textbook
o	Book_ID (FK)
o	Date
o	Set Price
o	Status
•	Sell Textbook
o	Student number (FK)
o	Book_ID (FK)
o	Date
•	Return textbooks
o	Book_ID(FK)
o	Date
o	Status
•	Change Status
o	Book_ID (FK)

