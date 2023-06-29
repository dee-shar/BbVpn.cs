#!/bin/bash

api="https://bbvpn.avdev.site"
user_agent="Dalvik/2.1.0 (Linux; U; Android 9; RMX3551 Build/PQ3A.190705.003)"

function login_with_token() {
	# 1 - token: (string): <token>
	token=$1
}

function get_servers() {
	curl --request GET \
		--url "$api/api.php?token=$token" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}

function get_api_parameters() {
	curl --request GET \
		--url "$api/apiParams.php?token=$token&v=v38" \
		--user-agent "$user_agent" \
		--header "content-type: application/json"
}
