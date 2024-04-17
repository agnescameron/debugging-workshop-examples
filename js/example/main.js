rabbitDiv = document.getElementById('bottom-layer')

function toggleRabbit() {
	document.getElementById('counter').html(counter)

	if(rabbitDiv.style.display = "none"){
		rabbitDiv.style.display = "block";
	}
	else if (rabbitDiv.style.display = "block") {
		rabbitDiv.style.display = "none";
	}
	else if (counter == 10) {
		document.getElementById('top-layer').style.backgroundColor = rgba(255, 255, 0, 0.5);
	}

	counter += 1
}

setInterval(toggleRabbit, 1000);