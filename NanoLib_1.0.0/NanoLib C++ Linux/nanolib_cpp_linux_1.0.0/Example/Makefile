.PHONY: all clean mkdir rebuild install uninstall

# set all paths
INC_PATH=-I./src -I./inc
LIB_PATH=-L./lib
OUT_PATH=./bin/
SRC_PATH=./src/
SHARED_OBJ_PATH=./lib/
SHARED_OBJ=$(wildcard $(SHARED_OBJ_PATH)*.so)
TARGET_PATH := /usr/local/lib/nanotec

# compiler settings
CC=/usr/bin/g++
CFLAGS=-std=c++17 -Wall -Wextra -pedantic -O2 -pthread $(INC_PATH)

# linker settings
LIBS=-lnanolib -ldl

# main target
EXECUTABLE=$(OUT_PATH)example

# grab all cpp files from source folder for compiling
SOURCES=$(wildcard $(SRC_PATH)*.cpp)
OBJECTS=$(patsubst $(SRC_PATH)%.cpp, $(OUT_PATH)%.o, $(SOURCES))

all: mkdir $(EXECUTABLE)

rebuild: clean all

$(OUT_PATH)%.o : $(SRC_PATH)%.cpp
	$(CC) $(CFLAGS) -c $< -o $@

$(EXECUTABLE): $(OBJECTS)
	$(CC) $(CFLAGS) -o $(EXECUTABLE) $^ $(LIB_PATH) $(LIBS)
# needed capabilitiese
	sudo setcap 'cap_net_admin,cap_net_raw,cap_sys_nice+eip' $(OUT_PATH)example

clean:
	rm -rf $(OUT_PATH)

mkdir:
	@mkdir -p bin

install:
	@mkdir -p $(TARGET_PATH)
	install $(SHARED_OBJ) $(TARGET_PATH)
	ldconfig $(TARGET_PATH)

uninstall:
	@(for file in $(SHARED_OBJ) ; \
	do \
	LIB_NAME=$$(echo $$file | awk -F'/' '{print $$(NF)}'); \
	rm -f $(TARGET_PATH)/$$LIB_NAME; \
	done)
