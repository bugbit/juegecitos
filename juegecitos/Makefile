.PHONY: clean All

All:
	@echo "----------Building project:[ libcore - Debug ]----------"
	@cd "core" && "$(MAKE)" -f  "libcore.mk"
	@echo "----------Building project:[ jetpac - Debug ]----------"
	@cd "jetpac" && "$(MAKE)" -f  "jetpac.mk"
clean:
	@echo "----------Cleaning project:[ libcore - Debug ]----------"
	@cd "core" && "$(MAKE)" -f  "libcore.mk"  clean
	@echo "----------Cleaning project:[ jetpac - Debug ]----------"
	@cd "jetpac" && "$(MAKE)" -f  "jetpac.mk" clean
