from MUser import MUser

class MUserUI:
    @staticmethod
    def menu():
        print("1. Sign IN")
        print("2. Sign UP")
        x = int(input("Enter your option : "))
        return x
    
    @staticmethod
    def sign_up():
        username = input("Enter username: ")
        password = input("Enter password: ")
        role = input("Enter role: ")
        user = MUser(username,password,role)
        return user
    
    @staticmethod
    def sign_in():
        username = input("Enter username: ")
        password = input("Enter password: ")
        user = MUser(username,password,None)
        return user