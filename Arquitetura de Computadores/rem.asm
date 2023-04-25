	.text
		li $t0, 4
		li $t1, 10
		rem $t2, $t1, $t0
		
		syscall
		li $a0, 10