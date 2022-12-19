	.text
		li $t0, 4
		li $t1, 8
		div $t2, $t1, $t0 # Ainda é possível armazenar resultado no registrador lo
		
		syscall
		li $a0, 10
	.data