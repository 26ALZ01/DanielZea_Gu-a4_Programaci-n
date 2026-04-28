//Pseint
Algoritmo Lecc1_Act1_Inc1
	Definir cajonesOcupados, capacidadTotal, opcionn Como Entero
	capacidadTotal=10
	cajonesOcupados=0
	
	Repetir
		Escribir "-----SISTEMA DE ACCESO-----"
		Escribir "Cajones Ocupados: ", cajonesOcupados,"/",capacidadTotal
		Escribir "Cajones Disponibles: ", capacidadTotal-cajonesOcupados
		Escribir "Presione [1] para ingresar un auto o [0] para salir del sistema"
		Leer opcionn
		
		Si opcionn=1 Entonces
			cajonesOcupados=cajonesOcupados+1
			Escribir "Ticket impreso, ¡BIENVENIDO!"
		SiNo
			si opcionn <> 0 Entonces
				Escribir "Opción no válida"
			FinSi
		Fin Si
		Escribir "---------------------------------------------------------------"
	Hasta Que cajonesOcupados>=capacidadTotal o opcionn=0
	
	si cajonesOcupados>=capacidadTotal Entonces
		Escribir "AVISO: ¡Estacionamiento lleno!"
		Escribir "NO SE PERMITEN MÁS INGRESOS"
	FinSi
	
	Escribir "Cerrando el sistema de monitoreo"
	
FinAlgoritmo
