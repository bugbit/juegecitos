.PHONY: clean All

codelite-make := codelite-make -w juegecitos.workspace -c wasm
core:
	$(codelite-make) -p core -e
jetpac:
	core && $(codelite-make) -p jetpac -e
all:
	$(codelite-make) -d build
	$(MAKE)
clean:
	$(codelite-make) -d clean
	$(MAKE)
