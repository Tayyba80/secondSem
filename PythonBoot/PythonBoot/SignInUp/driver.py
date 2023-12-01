from MUSerDL import MUserDL
from MUserUI import MUserUI



MUserDL.readFile()
#  print([i.username for i in MUserDL.usersList])
option = 0

while option != 3:
    option = MUserUI.menu()
    if option == 1:
        user = MUserUI.sign_in()
        if user != None: 
            if user.isAdmin():
                print('Admin Side Entered')
                # Admin functionality
            else:
                print('Customer Side Entered')
                #Customer Side
    elif option == 2:
        user = MUserUI().sign_up()
        MUserDL.addUser(user)
        MUserDL.storeFile()
