# Multiplica��o em assembly
## Author: Nicolas M. Ferreira
# Data: 09/12/2022

.text
	li $v0, 12 # Carrega os dados no registrador
	addi $v1, $zero, 10
	
	# $a1 ter� o resultado da multiplica��o dos end. $v0 e $v1
	mul $a1, $v0, $v1
