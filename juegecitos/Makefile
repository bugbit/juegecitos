.PHONY: clean All

All:
	@echo "----------Building project:[ core - Debug ]----------"
	@cd "core" && "$(MAKE)" -f  "core.mk"
	@echo "----------Building project:[ jetpac - Debug ]----------"
	@cd "jetpac" && "$(MAKE)" -f  "jetpac.mk"
clean:
	@echo "----------Cleaning project:[ core - Debug ]----------"
	@cd "core" && "$(MAKE)" -f  "core.mk"  clean
	@echo "----------Cleaning project:[ jetpac - Debug ]----------"
	@cd "jetpac" && "$(MAKE)" -f  "jetpac.mk" clean
