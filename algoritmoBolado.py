'''
      ´ B ------ E -- `
    A  ----- D  ------ F
      ` C --´-------- ´

'''

from random import randint

cities = []

cityA = {"nome": "", "caminhos": {}}
cityB = {"nome": "", "caminhos": {}}
cityC = {"nome": "", "caminhos": {}}
cityD = {"nome": "", "caminhos": {}}
cityE = {"nome": "", "caminhos": {}}
cityF = {"nome": "", "caminhos": {}}

cities = []

minDistance = 1
maxDistance = 10

# inicio do método initializecities
def initializecities():
  global cityA
  global cityB
  global cityC
  global cityD
  global cityE
  global cityF

  global cities

  #inicialização da cidade A
  cityA = {
    "nome": "cidade A",
    "caminhos" : {
      "A para B": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityB.copy(),
      },
      "A para C": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityC,
      },
      "A para D": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityD,
      }
    }
  }
  #inicialização da cidade B
  cityB = {
    "nome": "cidade B",
    "caminhos" : {
      "B para A": {
        "distancia": cityA["caminhos"]["A para B"]["distancia"],
        "destino": cityA,
      },
      "B para E": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityE,
      },
    }
  }
  #inicialização da cidade C
  cityC = {
    "nome": "cidade C",
    "caminhos" : {
      "C para A": {
        "distancia": cityA["caminhos"]["A para C"]["distancia"],
        "destino": cityA,
      },
      "C para D": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityD,
      },
      "C para F": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityF,
      }
    }
  }
  #inicialização da cidade D
  cityD = {
    "nome": "cidade D",
    "caminhos" : {
      "D para A": {
        "distancia": cityA["caminhos"]["A para D"]["distancia"],
        "destino": cityA,
      },
      "D para C": {
        "distancia": cityC["caminhos"]["C para D"]["distancia"],
        "destino": cityC,
      },
      "D para F": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityE,
      }
    }
  }
  #inicialização da cidade E
  cityE = {
    "nome": "cidade E",
    "caminhos" : {
      "E para B": {
        "distancia": cityB["caminhos"]["B para E"]["distancia"],
        "destino": cityB,
      },
      "E para F": {
        "distancia": randint(minDistance,maxDistance),
        "destino": cityF,
      },
    }
  }
  #inicialização da cidade F
  cityF = {
    "nome": "cidade F",
    "caminhos" : {
      "F para C": {
        "distancia": cityC["caminhos"]["C para F"]["distancia"],
        "destino": cityC,
      },
      "F para D": {
        "distancia": cityD["caminhos"]["D para F"]["distancia"],
        "destino": cityD,
      },
      "F para E": {
        "distancia": cityE["caminhos"]["E para F"]["distancia"],
        "destino": cityE,
      }
    }
  }

  # atualizar valores
  cityE["caminhos"]["E para F"]["destino"] = cityF
  
  cityD["caminhos"]["D para F"]["destino"] = cityF

  cityC["caminhos"]["C para D"]["destino"] = cityD
  cityC["caminhos"]["C para F"]["destino"] = cityF

  cityB["caminhos"]["B para E"]["destino"] = cityE

  cityA["caminhos"]["A para B"]["destino"] = cityB
  cityA["caminhos"]["A para C"]["destino"] = cityC
  cityA["caminhos"]["A para D"]["destino"] = cityD

  cities = [ cityA,cityB,cityC,cityD,cityE,cityF,  ]
# final do método initializecities

def elementExists(lista, element):
  for i in lista:
    if(i == element):
      return True
  return False;

# inicio do método showcities 
def showcities():
  global cities
  for city in cities:
    if( not city is None ):
      print(city["nome"])
      for path in city["caminhos"]:
        print("\t {0} = {1} km".format(path, city["caminhos"][path]["distancia"])  )
  print("")
# final do método showcities
Firstfind = False
def cityToCity(city1,city2):
  for caminho in city1["caminhos"]:
    if( city1["caminhos"][caminho]["destino"]["nome"] == city2["nome"] ):
      return city1["caminhos"][caminho]["distancia"]

# inicio do método getBestPath 
def travel(currentCity, currentcities,currentPath):
  global initialCity, endCity, paths, Firstfind
  for path in currentCity["caminhos"].keys():
    
    if (Firstfind):
      beforeCity = currentCity
      
      if(beforeCity != currentCity):
        currentPath["caminho"] -= cityToCity(beforeCity,currentCity)
      Firstfind = False    
    '''
    print("Cidade atual: ",currentCity["nome"])
    
    print("caminhos da cidade atual: ", [x for x in currentCity["caminhos"].keys()] )
    print("próxima cidade: ",path)
    print("cidades que já passaram: ", [ x["nome"] for x in currentcities] )
    print("caminhado: ", currentPath["caminho"] )
    print("")
    '''
    if( currentCity["caminhos"][path]["destino"] in currentcities ):
      #print(" ========== já existe ========== \n")
      continue

    if( currentPath["cidades"] == "none" ):
      currentPath["cidades"] = "{0} para {1}".format(currentCity["nome"], currentCity["caminhos"][path]["destino"]["nome"] )
      currentPath["caminho"] = currentCity["caminhos"][path]["distancia"]
      tempCurrentCity = currentCity["caminhos"][path]["destino"]
      currentcities.append(currentCity)
      if( currentCity["caminhos"][path]["destino"] == endCity):
        paths["cidades"].append( currentPath["cidades"] )
        paths["caminhos"].append(currentPath["caminho"])
        '''
        print(" ========== Achou um caminho ========== ")
        print("todo caminho: ",currentPath["caminho"]," \n")
        print("coletania paths: ",paths["caminhos"])
        print("\n")
        '''
        currentPath["caminho"] -= currentCity["caminhos"][path]["distancia"]
        currentPath["cidades"] = currentPath["cidades"].replace(" para {0}".format( currentCity["caminhos"][path]["destino"]["nome"] ),"")

        currentcities.remove( currentcities[-1])
        Firstfind = True
        return

      travel(tempCurrentCity, currentcities,currentPath)
      currentPath["cidades"] = currentPath["cidades"].replace(" para {0}".format( currentCity["caminhos"][path]["destino"]["nome"] ),"")
      currentPath["caminho"] -= currentCity["caminhos"][path]["distancia"]
    else:
      if( currentCity["caminhos"][path]["destino"] == endCity):
        currentPath["cidades"] += " para {0}".format( currentCity["caminhos"][path]["destino"]["nome"] )
        currentPath["caminho"] += currentCity["caminhos"][path]["distancia"]
        #currentcities.clear()
        paths["cidades"].append( currentPath["cidades"] )
        paths["caminhos"].append(currentPath["caminho"])
        '''
        print(" ========== Achou um caminho ========== ")
        print("todo caminho: ",currentPath["caminho"]," \n")
        print("coletania paths: ",paths["caminhos"])
        print("\n")
        '''
        currentPath["caminho"] -= currentCity["caminhos"][path]["distancia"]
        currentPath["cidades"] = currentPath["cidades"].replace(" para {0}".format( currentCity["caminhos"][path]["destino"]["nome"] ),"")

        currentcities.remove( currentcities[-1])
        Firstfind = True
        return
      else:
        currentPath["cidades"] += " para {0}".format( currentCity["caminhos"][path]["destino"]["nome"] )
        currentPath["caminho"] += currentCity["caminhos"][path]["distancia"]
        tempCurrentCity = currentCity["caminhos"][path]["destino"]
        currentcities.append(currentCity)
        travel(tempCurrentCity, currentcities,currentPath)
        currentPath["caminho"] -= currentCity["caminhos"][path]["distancia"]
        currentPath["cidades"] = currentPath["cidades"].replace(" para {0}".format( currentCity["caminhos"][path]["destino"]["nome"] ),"")

    '''
    print("before: ",path)
    begin = path[0]
    end = path[-1]
    path = end + path[1:-1] + begin
    print("after: ",path)
    print("paths: ", [x for x in currentCity["caminhos"]] )
    print("\n -------  \n")
    '''
    
  currentcities.remove( currentcities[-1])
# final do método getBestPath

# inicio do método getBestPath 
def getBestPath():
  global paths, initialCity
  currentcities = [initialCity]
  currentCity = initialCity
  currentPath = {"cidades": "none", "caminho": 0 }
  travel(currentCity, currentcities, currentPath)
  
  print("Todas as rotas: ")
  for i in range(len(paths["caminhos"])): 
    print("caminho: ",paths["cidades"][i],"\n km: ",paths["caminhos"][i])
    print("")
  
  bestPath = paths["cidades"][ paths["caminhos"].index(min(paths["caminhos"])) ]
  print("Melhor rota: ",bestPath)
# final do método getBestPath

initializecities()
showcities()

paths = {"cidades": [], "caminhos": [] }
citiesTravel = []
ask = '''
    A - 1
    B - 2
    C - 3
    D - 4
    E - 5
    F - 6
'''
start = int(input("Insira o número da cidade que deseja começar: "+ask))
while( start < 1 or start > 6 ):
    print("valor inválido")
    start = int(input("Insira o número da cidade que deseja começar: "+ask))

end = int(input("Insira o número da cidade destino: "+ask))
while( end < 1 or end > 6 or end == start ):
    print("valor inválido")
    end = int(input("Insira o número da cidade destino: "+ask))

start -= 1
end -= 1

initialCity = cities[start]
endCity = cities[end]
getBestPath()
indxBestPath = paths["caminhos"].index( max(paths["caminhos"]) )