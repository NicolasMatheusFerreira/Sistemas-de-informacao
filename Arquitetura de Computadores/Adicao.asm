# Adicao em assembly
# # Author: Nicolas M. Ferreira
# Data: 09/12/2022
# Versao 1.0
.text

	li $t0, 75
	li $t1, 25
	li $t2, 30
	li $t3, 20
	li $t4, 2
	li $t5, 8
	#add $s0, $t0, $t1
	#addi $s0, $t0, 36
	add $t0, $t2, $t3
	addi $t7, $zero, 5 
	mult $t4, $t5 

	 