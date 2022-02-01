.PHONY: clean All

All:
	@echo "----------Building project:[ box2d - wasm ]----------"
	@cd "box2d" && "$(MAKE)" -f  "box2d.mk"
	@echo "----------Building project:[ core - wasm ]----------"
	@cd "core" && "$(MAKE)" -f  "core.mk"
	@echo "----------Building project:[ jetpac - wasm ]----------"
	@cd "jetpac" && "$(MAKE)" -f  "jetpac.mk"
clean:
	@echo "----------Cleaning project:[ box2d - wasm ]----------"
	@cd "box2d" && "$(MAKE)" -f  "box2d.mk"  clean
	@echo "----------Cleaning project:[ core - wasm ]----------"
	@cd "core" && "$(MAKE)" -f  "core.mk"  clean
	@echo "----------Cleaning project:[ jetpac - wasm ]----------"
	@cd "jetpac" && "$(MAKE)" -f  "jetpac.mk" clean
