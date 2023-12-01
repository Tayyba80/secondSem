from MUser import MUser    # this is importing modules
import os.path

class MUserDL:
    usersList = []
    
    # creating static methods
    @staticmethod
    def addUser(user):
        MUserDL.usersList.append(user)
    
    @staticmethod
    def SignIn(user):
        for storedUser in MUserDL.usersList:
            if(storedUser.username == user.username and storedUser.password == user.password):
                return storedUser
        
        return None
    
    @staticmethod
    def parse(line):
        split_record = []
        split_record = line.split(",")
        if(len(split_record) != 1):
            return split_record[0],split_record[1],split_record[2]
        else:
            return [None,None,None]
    
    @staticmethod
    def readFile():
        path = "dataUser.txt"
        if(os.path.exists(path)):
            file = open(path,'r')
            records = file.read().split("\n")
            file.close()
            
            for line in records:
                username , password , role = MUserDL.parse(line)  
                if username != None:
                    user = MUser(username,password,role)
                    MUserDL.addUser(user)
                
            return True
        else:
            return True
    
    @staticmethod
    def storeFile():
        path = "dataUser.txt"
        file = open(path,'w')
        for storedUser in MUserDL.usersList:
            file.write(str(storedUser.username) + "," + str(storedUser.password) + "," + str(storedUser.role) + "\n")
        file.close()
            